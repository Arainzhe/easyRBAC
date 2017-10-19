﻿using System;
using System.Collections.Generic;
using System.Text;
using EasyRbac.Domain.Enums;
using SQLinq;

namespace EasyRbac.Domain.Entity
{
    [SQLinqTable("Application")]
    public class ApplicationEntity
    {
        public long Id { get; set; }
        public string AppName { get; set; }

        public string AppCode { get; set; }

        public bool Enable { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;

        public string Descript { get; set; }

        public string CallbackUrl { get; set; }

        public string AppScret { get; set; }

        public CallbackType CallbackType { get; set; }

        [SQLinqColumn(Ignore = true)]
        public List<AppResourceEntity> AppResouce { get; set; }
    }
}
