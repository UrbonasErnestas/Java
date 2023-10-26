
class Time {
    private int hour, min, sec;
    public Time(){
        set(0,0,0);
    }
    public Time(int p_hour, int p_min, int p_sec){
        set(p_hour, p_min, p_sec);
    }
    public Time(Time original){
        hour = original.hour;
        min = original.min;
        sec = original.sec;
    }
    public int getTotalSec(){
        return hour * 3600 + min * 60 + sec;
    }
    public void makeTimeFromSec(int totalSec){
        hour = totalSec / 3600;
        min = (totalSec - hour * 3600) / 60;
        sec  = (totalSec - hour * 3600 - min * 60);
    }
    public void set(int p_hour, int p_min, int p_sec){
        if (p_hour < 0) p_hour = 0;
        hour = p_hour;
        min = p_min;
        sec = p_sec;
        int totalSec = getTotalSec();
        makeTimeFromSec(totalSec);

        /*
        hour = p_hour;
        min = p_min;
        sec = p_sec;
        if (sec > 59){
            min = min + sec / 60;
            sec = sec % 60;
        }
        if (min > 59){
            hour = hour + min / 60;
            min = min % 60;
        }
        */
    }
    public void print(){
        if (hour < 10) System.out.print("0");
        System.out.print(hour + ":");
        if (min < 10) System.out.print("0");
        System.out.print(min + ":");
        if (sec < 10) System.out.print("0");
        System.out.println(sec);
    }
    static public Time timeDiff(Time time1, Time time2){
        Time result = new Time();
        int timeDiffInSec = Math.abs(time1.getTotalSec() - time2.getTotalSec());
        result.makeTimeFromSec(timeDiffInSec);
        return result;
    }
}

class Event {
    private String title;
    private Time start, end;
    public Event(){
        title = "Unknown";
        start = new Time(9,0,0);
        end = new Time(10,0,0);
    }
    public Event(String p_title, Time p_start, Time p_end){
         title = p_title;
         start = new Time(p_start);
         end = new Time(p_end);
    }
    public void print(){
        System.out.println("Title: " + title);
        System.out.println("Begin: "); start.print();
        System.out.println("End: "); end.print();
        Time duration = Time.timeDiff(end,start);
        System.out.println("Duration: "); duration.print();

    }
}

public class Main {

    public static void main(String[] args) {
        Event event = new Event();
        event.print();
        Event javaLecture = new Event("Java",
                new Time( 8, 30 , 0),
                new Time(11,45,0));
        javaLecture.print();

      /*  Time time1 = new Time(1,62,140);
        time1.print();
        Time time2 = new Time(0,3,20);
        time2.print();
        Time time3 = new Time();
        time3 = Time.timeDiff(time2, time1);
        time3.print();
*/
    }
}