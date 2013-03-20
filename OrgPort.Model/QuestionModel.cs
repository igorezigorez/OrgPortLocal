﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrgPort.Model
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public UserInformationModel User { get; set; }
        public UserInformationModel TargetUser { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
    }
}