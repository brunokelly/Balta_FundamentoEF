﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(160)]
        [Column("Title", TypeName = "VARCHAR")]
        public string Title { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("Summary", TypeName = "VARCHAR")]
        public string Summary { get; set; }

        [Required]
        [Column("Body", TypeName = "NTEXT")]
        public string Body { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Slug", TypeName = "NTEXT")]
        public string Slug { get; set; }

        [Required]
        [Column("CreateDate", TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Required]
        [Column("LastUpdateDate", TypeName = "DATETIME")]
        public DateTime LastUpdateDate { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }  


        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }

    }
}
