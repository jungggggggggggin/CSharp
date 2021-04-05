using System;


namespace JavaToCsharp_Report
{
	class Program
	{
		public interface Stack
		{
			bool Empty { get; }
			void push(char item);
			char pop();
			void delete();
			char peek();
		}
		public class StackNode
		{
			internal char data;   //internal 같은 네임스페이스 내에서 자유롭게 접근
			internal StackNode link;
		}

		public class LinkedStack : Stack //상속 (자식:부모) LinkendStack은 Stack을 상속한다
		{
			private StackNode top; //07.pdf p.11 접근수정자(private)

			public bool Empty
			{
				get
				{
					return (top == null);
				}
			}
			// 위에서 top 썼으므로 쓸라면 재정의! 위의 top과 밑의 top은 다른개념이지..? 맞나?
			public void push(char item) // public virtual void push(char item) 도 가능인가?
			{
				StackNode newNode = new StackNode(); //StackNode의 새 객체는 newNode라는거 
				newNode.data = item; // 즉 스택노드의 문자char이 item으로 되고(객체의 멤버 참조 점 연산자 사용 pdf07. p8 참고해씀)
				newNode.link = top;  //newNode의 link가 top이되는데
				top = newNode;       //top은 newNode라는거
				// System.out.println("Inserted Item : " + item);
			}

			public char pop() //pop()는 스택이 비어있으면 비었다고 출력멘트 하고 안비어있으면 스택에 쌓는다 (newNode)
			{
				if (Empty)
				{
					Console.WriteLine("Deleting fail! Linked Stack is empty!!");
					return (char)0;
				}
				else
				{
					char item = top.data;
					top = top.link;
					return item;
				}
			}

			public void delete() //delete()는 비었으면 비었다고 출력하고 아니면 newNode의 top에서 뺌
			{
				if (Empty)
				{
					Console.WriteLine("Deleting fail! Linked Stack is empty!!");

				}
				else
				{
					top = top.link;
				}
			}

			public char peek() //peek()은 비었으면 없다고 하고 아니면 newNode의 문자를 반환
			{
				if (Empty)
				{
					Console.WriteLine("Peeking fail! Linked Stack is empty!!");
					return (char)0;
				}
				else
				{
					return top.data;
				}
			}

			public void PrintStack() 
			{
				if (Empty) //printstack()은 비었으면 비었다고 
				{
					Console.Write("Linked Stack is empty!! %n %n");
				}
				else //아니면
				{
					StackNode temp = top; 
					Console.WriteLine("Linked Stack>> "); //이 문장을 붙여서
					while (temp != null) //temp안에 비어있지않다면 char을 출력하는것 
					{
						Console.Write("\t {0} \n", temp.data); 
						temp = temp.link; 
					}
					Console.WriteLine();
				}
			}
		}
		public class OptExp
		{
			private string exp;
			private int expSize;
			private char testCh, openPair;

			public bool TestPair(string exp)
			{
				this.exp = exp;
				LinkedStack S = new LinkedStack();
				expSize = this.exp.Length; //expSize는 exp의 길이
				for (int i = 0; i < expSize; i++) //i가 exp길이보다 커지면 중단 stack에 있는걸 다 읽으면 중단! 
				{
					testCh = this.exp[i]; //문자열의 첫번쩨가
					switch (testCh) //switch문은 브레이크 없으면 계속 내려감
					{
						case '(':
						case '{':
						case '[':
							S.push(testCh); //열린괄호 들이 있으면 넣고
							break;
						case ')':
						case '}':
						case ']':
							if (S.Empty) //스택이 비어있으면 false
							{
								return false;
							}
							else
							{
								openPair = S.pop(); //&&는 둘다 참이여야 참 ||는 하나라도 참이면 참
								if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}') || (openPair == '[' && testCh != ']'))
								{
									return false;
								}
								else 
								{
									break;
								}
							}
					}
				}
				if (S.Empty) //스택을 다 검토 하였으면 .. 
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}
		public class BracketTest
		{

			public static void Main(string[] args)
			{
				OptExp opt = new OptExp();
				string exp = "(3*5)-6/2)";

				Console.WriteLine(exp); //문자열 반환

				if (opt.TestPair(exp))
				{
					Console.WriteLine("괄호 맞음!!");
				}
				else
				{
					Console.WriteLine("괄호 틀림!!");
				}
			}
		}
	}
}
