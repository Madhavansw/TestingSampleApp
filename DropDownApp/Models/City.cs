﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DropDownApp.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        public int CityId { get; set; }
}