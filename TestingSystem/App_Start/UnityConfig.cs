using System;
using TestingSystem.Data.Infrastructure;
using TestingSystem.Data.Repositories;
using TestingSystem.Sevice;
using Unity;

namespace TestingSystem
{
    
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

       
        public static IUnityContainer Container => container.Value;
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IDbFactory, DbFactory>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();

            container.RegisterType<IQuestionRepository, QuestionRepository>();
            container.RegisterType<IQuestionService, QuestionService>();
            container.RegisterType<IQuestionCategoryRepository, QuestionCategoryRepository>();
            container.RegisterType<IQuestionCategorySevice, QuestionCategorySevice>();

            container.RegisterType<IAnswerRepository, AnswerRepository>();
            container.RegisterType<IAnswerService, AnswerService>();
            container.RegisterType<IExamPaperRepository, ExamPaperRepository>();
            container.RegisterType<IExamPaperService, ExamPaperService>();
            container.RegisterType<IExamPaperQuestionService, ExamPaperQuestionService>();
            container.RegisterType<IExamPaperQuestionRepository, ExamPaperQuestionRepository>();
        }
    }
}