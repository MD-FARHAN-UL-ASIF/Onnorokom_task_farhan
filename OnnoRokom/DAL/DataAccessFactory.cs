﻿using DAL.EF;
using DAL.EF.Models;
using DAL.iINTERFACES;
using DAL.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Category, int, Category> CategoryData(DbContextOptions<DataContext> options)
        {
            return new CategoryRepo(options);
        }

        public static IQuestionRepo<Question, int, Question> QuestionData(DbContextOptions<DataContext> options)
        {
            return new QuestionRepo(options);
        }

        public static IAnswerRepo<Answer, int, Answer> AnswerData(DbContextOptions<DataContext> options)
        {
            return new AnswerRepo(options);
        }
    }
}
