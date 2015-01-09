using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using DatabaseGenerator.Mapping;
using DatabaseGenerator.XmlDeserialize;
using MappingAndBinding.ArionWebDbContext;
using Repositories.Implemantations;
using Repositories.Interfaces;
using Repositories.UnitOfWork;
using System.Diagnostics;

namespace DatabaseGenerator.Visitor
{
    public class HierarchyVisitor
    {
        protected Repository<Models.Coefficient> m_CoefficientRepository;
        protected Repository<Models.Description> m_DescriptionRepository;
        protected Repository<Models.Element> m_ElementRepository;
        protected Repository<Models.ElementClass> m_ElementClassRepository;
        protected Repository<Models.ElementGroup> m_ElementGroupRepository;
        protected Repository<Models.Key> m_KeyRepository;
        protected Repository<Models.Model> m_ModelRepository;
        protected Repository<Models.Position> m_PositionRepository;
        protected Repository<Models.Property> m_PropertyRepository;

        private HierarchyVisitor()
        {
            var context = new ArionWebDbContext(false);
            UnitOfWork unitOfWork = new UnitOfWork(context);

            m_CoefficientRepository = new Repository<Models.Coefficient>(unitOfWork);
            m_DescriptionRepository = new Repository<Models.Description>(unitOfWork);
            m_ElementRepository = new Repository<Models.Element>(unitOfWork);
            m_ElementClassRepository = new Repository<Models.ElementClass>(unitOfWork);
            m_ElementGroupRepository = new Repository<Models.ElementGroup>(unitOfWork);
            m_KeyRepository = new Repository<Models.Key>(unitOfWork);
            m_ModelRepository = new Repository<Models.Model>(unitOfWork);
            m_PositionRepository = new Repository<Models.Position>(unitOfWork);
            m_PropertyRepository = new Repository<Models.Property>(unitOfWork);
        }

        static HierarchyVisitor()
        {
            AutoMapperConfigurationForGenerator.Configure();
            var context = new ArionWebDbContext(true);
            context.Database.Initialize(true);
        }

        public static void Visit(Hierarchy hierarchy)
        {
            int totalClasses = hierarchy.ElementClasses.Length;
            int classesCompleted = 0;
            Console.WriteLine(string.Format("Total classes - {0}", totalClasses));

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Parallel.ForEach(hierarchy.ElementClasses, (elementClass) =>
                {
                    HierarchyVisitor visitor = new HierarchyVisitor();
                    visitor.Visit(elementClass);
                    int safeClasseCompleted = Interlocked.Increment(ref classesCompleted);
                    Console.WriteLine(string.Format("Completed- {0}/{1}", safeClasseCompleted, totalClasses));
                });
            stopwatch.Stop();
            Console.WriteLine(string.Format("Elapsed time- {0}", stopwatch.Elapsed));
        }


        protected void Visit(ElementClass elementClass)
        {
            Models.ElementClass elementClassToSave = m_ElementClassRepository.Create(Mapper.Map<Models.ElementClass>(elementClass));
            if (elementClass.Owner != null)
            {
                foreach (var owner in elementClass.Owner)
                {
                    Visit(owner, elementClassToSave);
                }
            }
        }

        protected void Visit(Owner owner, Models.ElementClass elementClass)
        {
            Models.Position position = Mapper.Map<Models.Position>(owner);
            elementClass.Positions.Add(position);
            if (owner.Groups != null)
            {
                foreach (var group in owner.Groups)
                {
                    Visit(group, position, elementClass);
                }
            }
        }

        protected void Visit(Group group, Models.Position position, Models.ElementClass elementClass)
        {
            Models.Model model = m_ModelRepository.Create(Mapper.Map<Models.Model>(group.GroupModel));
            Models.ElementGroup elementGroupForCreating =  Mapper.Map<Models.ElementGroup>(group);
            elementGroupForCreating.Model = model;
            elementGroupForCreating.Position = position;
            elementGroupForCreating.ElementClass = elementClass;

            Models.ElementGroup elementGroup = m_ElementGroupRepository.Create(elementGroupForCreating);
            position.ElementGroups.Add(elementGroup);
            if (group.GroupProperties != null)
            {
                foreach (var groupProperty in group.GroupProperties)
                {
                    Visit(groupProperty, elementGroup);
                }
            }
        }

        protected void Visit(GroupProperty groupProperty, Models.ElementGroup elementGroup)
        {
            Models.Property property = m_PropertyRepository.Create(Mapper.Map<Models.Property>(groupProperty));
            elementGroup.Properties.Add(property);
            if (groupProperty.PropertyOptions != null)
            {
                foreach (var propertyOption in groupProperty.PropertyOptions)
                {
                    Visit(propertyOption, property);
                }
            }
        }

        protected void Visit(PropertyOption propertyOption, Models.Property property)
        {
            Models.Description description = m_DescriptionRepository.Create(Mapper.Map<Models.Description>(propertyOption));
            property.Descriptions.Add(description);
            if (propertyOption.GroupProperty != null)
            {
                foreach (var groupProperty in propertyOption.GroupProperty)
                {
                    Visit(groupProperty, description);
                }
            }
            if (propertyOption.Keys != null)
            {
                foreach (var key in propertyOption.Keys)
                {
                    Visit(key, description);
                }
            }
        }

        protected void Visit(GroupProperty groupProperty, Models.Description description)
        {
            Models.Property property = m_PropertyRepository.Create(Mapper.Map<Models.Property>(groupProperty));
            description.Properties.Add(property);
            if (groupProperty.PropertyOptions != null)
            {
                foreach (var propertyOption in groupProperty.PropertyOptions)
                {
                    Visit(propertyOption, property);
                }
            }
        }

        protected void Visit(Key key, Models.Description description)
        {
            Models.Key keyToSave = m_KeyRepository.Create(Mapper.Map<Models.Key>(key));
            description.Keys.Add(keyToSave);
        }
    }
}
