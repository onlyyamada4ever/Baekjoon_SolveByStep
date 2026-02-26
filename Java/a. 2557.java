// import java.io.BufferedWriter;
// 이번 문제에선 println을 사용했지만, 출력이 많아질 경우엔 데이터를 버퍼에 모아서 한번에 출력하는 
// BufferedWriter을 사용해야 하기 때문에 BufferedWriter 코드도 적어둠.
import java.io.OutputStreamWriter;
import java.io.IOException;
 
public class Main {
	public static void main(String[] args) throws IOException {
        System.out.println("Hello World!");
		// Hello World! 출력
		
		/*
        BufferedWriter bw = new BufferedWriter(new OutputStreamWriter(System.out));
 
		bw.write("Hello World!");
		bw.flush();
		bw.close();
        */
	}
}
