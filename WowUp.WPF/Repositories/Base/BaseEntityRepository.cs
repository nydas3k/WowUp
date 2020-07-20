﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WowUp.WPF.Repositories.Base
{
    public class BaseEntityRepository<TEntity> : BaseRepository
        where TEntity : new()
    {

        protected ObservableCollection<TEntity> _entities;

        public BaseEntityRepository(): base()
        {
            _database.CreateTable<TEntity>();
            _entities = new ObservableCollection<TEntity>(_database.Table<TEntity>());
        }
    }
}
