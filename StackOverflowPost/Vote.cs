using System;

namespace OOP_With_CSharp
{
    public class Vote
    {
        public int UpCount = 0;
        public int DownCount = 0;
        public int UpVote()
        {
            return UpCount++;
        }

        public int DownVote()
        {
            return DownCount++;
        }
    }
}