﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent{ get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage{ get; set; }
        public string BlogCreateDate{ get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
		public int WriterID { get; set; }
		public Writer writer { get; set; }
		public List<coments> Comments { get; set; }


    }
}
