
//abstract class HistoricalDate{
//   abstract void print();
//}
//class UnixTime extends HistoricalDate {
//    void print(){
//        System.out.println("Unix time measures time by the number of seconds since 1 January 1970");
//    }
//}
//class FirstWebsite extends HistoricalDate {
//    void print(){
//        System.out.println("1989 invented the World WIde Web (WWW)");
//    }
//}
//---------------------
//abstract class MediaPlayer {
//    abstract void play();
//    abstract  void pause();
//    void stop() {
//        System.out.println("Media stopped.");
//    }
//}
//class AudioPlayer extends MediaPlayer {
//
//    void play() {
//        System.out.println("Audio playing ...");
//    }
//    void pause() {
//        System.out.println("Audio paused...");
//    }
//    void stop(){
//        System.out.println("Audio stopped...");
//    }
//}
//class VideoPlayer extends MediaPlayer {
//
//    void play() {
//        System.out.println("Video playing...");
//    }
//    void pause() {
//        System.out.println("Video paused...");
//    }
//    void stop(){
//        System.out.println("Video stopped...");
//    }
//}

abstract class Employee {
    String name, id, department;
    Employee(String name, String id, String department){
        this.name = name;
        this.id = id;
        this.department = department;
    }
    abstract double calculateSalary();
    void printDetails(){
        System.out.println(name + ", " + id + ", " + department + ", " + calculateSalary() + " EUR");
    }
}

class FullTimeEmployee extends  Employee {
    FullTimeEmployee(String name, String id, String department) {
        super(name, id, department);
    }
    double calculateSalary(){
        return 2000;
    }
}

class PartTimeEmployee extends  Employee {
    PartTimeEmployee(String name, String id, String department) {
        super(name, id, department);
    }
    double calculateSalary(){
        return 1000;
    }
}

public class Main {
    public static void main(String[] args) {
//        HistoricalDate time = new UnixTime();
//        time.print();
//        HistoricalDate firstWebsite = new FirstWebsite();
//        firstWebsite.print();
//        HistoricalDate date = new HistoricalDate() {
//            @Override
//            void print() {
//                System.out.println("Unix time measures time by the number of seconds since 1 January 1970 - 2");
//            }
//        };
//        date.print();
        //-------------
//        MediaPlayer audioPlayer = new AudioPlayer();
//        audioPlayer.play();
//        audioPlayer.pause();
//        audioPlayer.stop();
//        MediaPlayer videoPlayer = new VideoPlayer();
//        videoPlayer.play();
//        videoPlayer.pause();
//        videoPlayer.stop();
        Employee fullTime = new FullTimeEmployee("SomeName", "12345", "IT");
        fullTime.printDetails();
        Employee partTime = new PartTimeEmployee("AnotherName", "45678", "Finance");
        partTime.printDetails();

    }
}