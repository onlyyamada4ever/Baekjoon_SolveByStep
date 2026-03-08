// https://www.acmicpc.net/problem/2557
// 백준 단계별로 풀어보기 - 입출력과 사칙연산
// 2557 Hello World

// 시간 제한 : 1초
// 메모리 제한 : 128 MB
// 문제 : Hello World! 를 출력하시오.
// 입력 : 없음
// 출력 : Hello World! 를 출력하시오

// 이번 문제에선 println을 사용했지만, 출력량이 많아질 경우 BufferedWriter을 사용해야 하기 때문에
// BufferedWriter 코드도 적어두고 주석처리 해 둠.

// import java.io.BufferedWriter;
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
