using System;

namespace EnQ_Admin.API.Leaders
{
    public interface Leaders
    {
        public string id { get; set; }
        public string startAt { get; set; }
        public string endAt { get; set; }
        public Array users { get; set; }
    }
}