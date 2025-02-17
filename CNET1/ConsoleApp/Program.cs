int Age(DateTime birth)
{
    DateTime now = DateTime.Now;

    TimeSpan diff = now - birth;

    return (int)(diff.TotalDays / 365);
}




