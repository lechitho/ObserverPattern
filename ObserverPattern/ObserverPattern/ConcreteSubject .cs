using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private string subjectState;
        // Gets or sets subject state
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
    }
}
