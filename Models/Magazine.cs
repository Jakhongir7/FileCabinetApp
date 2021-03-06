using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Magazine : Document
    {
        public string Publisher { get; set; }

        public int ReleaseNumber { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Publisher - {Publisher}");
            sb.AppendLine($"ReleaseNumber - {ReleaseNumber}");
            return base.ToString() + sb;
        }
    }
}
