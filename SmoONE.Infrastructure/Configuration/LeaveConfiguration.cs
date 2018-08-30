﻿using SmoONE.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoONE.Infrastructure
{
    // ******************************************************************
    // 文件版本： SmoONE 1.0
    // Copyright  (c)  2016-2017 Smobiler
    // 创建时间： 2016/11
    // 主要内容：  请假单表的配置信息类,通过Fluent API补全配置信息(最终的配置为DataAnnotations配置的+Fluent API配置的)
    // ******************************************************************
    /// <summary>
    /// 请假单表的配置信息类
    /// </summary>
    public class LeaveConfiguration : EntityTypeConfiguration<Leave>
    {
        /// <summary>
        /// 配置请假单表的映射信息
        /// </summary>
        public LeaveConfiguration()
        {
            Property(l => l.L_LDay).HasPrecision(10, 1);
        }
    }
}

