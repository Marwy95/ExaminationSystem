using Autofac;
using ExaminationSystem.Data;
using ExaminationSystem.Repositories;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.Services.Instructors;
using ExaminationSystem.Services.StudentCourses;
using ExaminationSystem.Services.Questions;
using ExaminationSystem.Services.NewFolder;
using ExaminationSystem.Mediators.Questions;
using ExaminationSystem.Services.Students;

namespace ExaminationSystem
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationDbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IInstructorService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(ICourseService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IStudentCourseService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IQuestionService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IChoiceService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IQuestionMediator).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(typeof(IStudentService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();

        }
    }
}
