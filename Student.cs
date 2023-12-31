namespace Giraffe
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;
        public Student(string sName, string sMajor, double sGpa)
        {
            name = sName;
            major = sMajor;
            gpa = sGpa;
        }
        public bool HasHonours()
        {
            if (gpa >= 4.5)
            {
                return true;
            }
            return false;
        }
        public bool IsCultist()
        {
            if (gpa <= 1.5)
            {
                return true;
            }
            return false;
        }
    }
}