using Dapper.FluentMap;
using DataBase.mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class DapperConfiguration
    {
        private static bool mapped;
        public static void Initialize()
        {
            if (mapped)
            {
                return;
            }
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new UserAccountMapper());
                config.AddMap(new ChatMapper());
                config.AddMap(new MessageMapper());
                
            });
        }

    }
}
