﻿using CommandLineApi.Infrastructure.Context;
using CommandLineApi.Infrastructure.Models;
using CommandLineApi.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Infrastructure.Repository.Implementation
{
    public class GenericCommandLineRepo<T> : IGenericCommandLineRepo<T> where T : class
    {
        private readonly CommandLineDbContext _commandLineDbContext;
        private readonly DbSet<T> _dbSet;
        public GenericCommandLineRepo(CommandLineDbContext commandLineDbContext)
        {
            _commandLineDbContext = commandLineDbContext;
            _dbSet = _commandLineDbContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllCommand()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetCommandById(string Id)
        {
            return await _dbSet.FirstAsync();
        }

        public async Task<T> GetCommandByName(string Name)
        {
            return await _dbSet.FirstAsync();
        }
    }
}
