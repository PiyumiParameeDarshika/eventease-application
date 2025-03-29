private List<string> AttendanceList = new List<string>();

public void MarkAttendance(string userName)
{
    if (!AttendanceList.Contains(userName))
    {
        AttendanceList.Add(userName);
    }
}
