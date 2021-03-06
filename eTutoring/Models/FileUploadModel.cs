﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eTutoring.Models
{
    public class FileUploadModel
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string FileId { get; set; }

        // Author
        public string AuthorId { get; set; }
        public virtual ApplicationUser Author { get; set; }

        // Comments
        public virtual ICollection<FileCommentModel> FileComments { get; set; }
    }
}