using Dealership.Common;

namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Dealership.Contracts;

    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get { return this.content; }
            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength, string.Format(Constants.StringMustBeBetweenMinAndMax, "Content", Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }

        public string Author { get; set; }
    }
}
