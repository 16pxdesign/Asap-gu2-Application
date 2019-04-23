﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Application.Data.Models;
using Application.Repo.Contracts;

namespace Application.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseModel _context;
        public MemberRepositories MemberRepositories { get; private set; }
        public TrainingRepositories TrainingRepositories { get; private set; }
        public ProfileRepository ProfileRepository { get; private set; }

        public UnitOfWork(DatabaseModel context)
        {
            _context = context;
            this.MemberRepositories = new MemberRepositories(context);
            this.TrainingRepositories = new TrainingRepositories(context);
            this.ProfileRepository = new ProfileRepository(context);
        }

        

        public void Dispose()
        {
           this._context.Dispose();
        }

        public async Task Commit()
        {
            await this._context.SaveChangesAsync();
        }
    }
}
