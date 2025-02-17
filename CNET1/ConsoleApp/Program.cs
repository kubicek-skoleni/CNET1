
// tuple
(double sum, int count, bool ordered) t1 = (4.5, 3, false);

double x = t1.sum;

double y = x + 5.3;

(int age, bool hadBday) Age(DateTime birth)
{
    DateTime now = DateTime.Now;

    TimeSpan diff = now - birth;

    int age = (int)(diff.TotalDays / 365);
    bool hadBday = now.DayOfYear >= birth.DayOfYear;

    return (age, hadBday);
}
