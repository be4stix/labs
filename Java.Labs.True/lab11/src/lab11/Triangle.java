
package lab11;
import java.awt.*;
public class Triangle {
	Point A,B,C;
	public Triangle(Point a,Point b,Point c){
		this.A =a ;
		this.B = b;
		this.C = c;			
	}
	
	void PointsInTriangle(Point[] d) {
		for(Point s : d) {
			if(this.PointInTriangle(s)) {
				System.out.println("Точка (" + s.X + ";" + s.Y +  ") Внутри"  );
			}
		}
		System.out.println("Stop");
	}
	boolean PointInTriangle(Point f){
		int[] b = new int[3];
		b[0] = (this.A.X - f.X)*(this.B.Y-this.A.Y)-(this.B.X-this.A.X)*(this.A.Y-f.Y);
		b[1] = (this.B.X - f.X)*(this.C.Y-this.B.Y)-(this.C.X-this.B.X)*(this.B.Y-f.Y);
		b[2] = (this.C.X - f.X)*(this.A.Y - this.C.Y)-(this.A.X - this.C.X)*(this.C.Y-f.Y);
		if ((b[0]>= 0 && b[1] >= 0 && b[2] >= 0 )|| (b[0]<= 0 && b[1] <= 0 && b[2] <= 0))
		{
			return true;
		}
		return false;
	}
	 public void paint(Graphics g) {
		 
	 }
	public static void main(String []args){
		
		
		Point[] s = new Point[5];
		s[0] = new Point(1,1);
		s[1] = new Point(2,2);
		s[2] = new Point(3,3);
		s[3] = new Point(4,4);
		s[4] = new Point(5,5);
		Point A = new Point(0,0);
		Point B = new Point(0,5);
		Point C = new Point(5,0);
		Triangle E = new Triangle(A,B,C);
		E.PointsInTriangle(s);
	}
}
