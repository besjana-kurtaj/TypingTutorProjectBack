﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingTutor.Domain
{
    public class UserProgress
    {
        public int UserProgressId { get; set; }
        public string UserId { get; set; }
        public int LessonId { get; set; }
        public double Speed { get; set; }
        public double Accuracy { get; set; }
        public DateTime CompletionDate { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Lesson Lesson { get; set; }
    }
}
