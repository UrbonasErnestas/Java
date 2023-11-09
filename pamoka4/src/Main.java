


class Time {
    private int hour, min, sec;
    public Time(){
        set(0,0,0);
    }
    public Time(int p_hour, int p_min, int p_sec){
    set(p_hour, p_min, p_sec);
    }
    public void set(int p_hour, int p_min, int p_sec){
        hour = p_hour;
        min = p_min;
        sec = p_sec;
    }

    int getHour(){
        return hour;
    }
    int getMin(){
        return min;
    }
    int getSec(){
        return sec;
    }
//    public void print(){
//        System.out.printf("%02d:%02d:%02d%n",hour,min,sec);
//    }

}

class DateTime extends Time {
    String month;
    int year, day;
    void set(int p_year, String p_month, int p_day, int p_hour, int p_min, int p_sec){
        year = p_year;
        month = p_month;
        day = p_day;
        super.set(p_hour, p_min, p_sec);
    }
    void print(){
        System.out.printf("%d %s %d %02d:%02d:%02d%n", year, month, day, getHour(), getMin(), getSec());
    }
}

class RunTime extends Time {
    private String processName;
    private int mili;
    public RunTime(String p_name, int p_hour, int p_min, int p_sec, int p_mili){
      //  set(p_name, p_hour, p_min, p_sec, p_mili);
        super(p_hour, p_min, p_sec);
        processName = p_name;
        mili = p_mili;
    }
    void set(String p_name, int p_hour, int p_min, int p_sec, int p_mili){
        processName = p_name;
        super.set(p_hour, p_min, p_sec);
        mili = p_mili;
    }
    void print(){
        System.out.printf("%s: %02d hours(s) %02d minutes(s) %02d second(s) %03d milisecond(s)",processName, getHour(), getMin(), getSec(), mili);
    }
}

public class Main {
    public static void main(String[] args) {
       RunTime runTime = new RunTime("Algorithm", 0 , 5, 10, 354);
      // runTime.set("Algorithm", 0 , 5, 10, 354);
       runTime.print();
    }
}