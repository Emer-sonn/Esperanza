using Esperanza.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Esperanza
{
    public class DBase
    {
        readonly SQLiteAsyncConnection _bancotexto;
        public DBase(string Path)
        {
            _bancotexto = new SQLiteAsyncConnection(Path);
            _bancotexto.CreateTableAsync<Model.Texto>().Wait();
        }

        public Task<List<Texto>> Listar()
        {
            return _bancotexto.Table<Texto>().ToListAsync();
        }
        public Task<Texto> Listar(int id)
        {
            return _bancotexto.Table<Texto>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }
        public Task<int> Adicionar(Texto t)
        {
            return _bancotexto.InsertAsync(t);
        }
        public Task<int> Deletar(Texto t)
        {
            return _bancotexto.DeleteAsync(t);
        }
    }
}