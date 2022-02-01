# I.Agile Development

# 1.Agile Practices

# 2.Overview of Extreme Programming

# 3.Planning

# 4.Testing





# 5.Refactoring

📌**What is the responsibility of software module?**

There are **3** functions.

- :one: The function <u>**perform**</u> while executing.
- :two: The function of a module to **<u>afford change</u>**.
- :three: The function to <u>**communicate**</u> to its reader.



📌**What Refactoring does?**

It helps the preceding 3 functions.



📌**Good Naming**

After reading this chapter, I found out a good name for variable is super important!!



📌**Split the Procedure**

An easy to understand code should be split into a clear function.



📌**Effect of Refactoring**

The structure of the program is isolated from parts to parts.

The program is much more easier to be changed.



📌**When should you to refactor?**

The answer is everyday! Clean your code everyday.



📌**Does refactoring important?**

Yes, it is super important. Because refactoring produces **clean code** which is the utmost importance. Before investing in principles and patterns, invest in clean code.



📌**Example of Refactoring**

Please refer to the following commits.

[Version 1](https://github.com/XingxinHE/SoftwareDevelopment/commit/aa2e6e7aacd2178c572ccfc06c43705c024c244c)

[Version 2](https://github.com/XingxinHE/SoftwareDevelopment/commit/3ebeb30e64804e7b11e9983c435a0f0bc6c428c1)

[Version 3](https://github.com/XingxinHE/SoftwareDevelopment/commit/663713ce4c20e49d4ae31bde25e62f837b977c4f)

[Version 4](https://github.com/XingxinHE/SoftwareDevelopment/commit/dfc6d57b4a69607e6f199d8e3f5d149f3d1b0b68)

[Version final](https://github.com/XingxinHE/SoftwareDevelopment/commit/07e03f3e46bc928fe4a8984cc00b8e4e9de45ec5)



# 6.Programming Episode

📌**What is user story?**

It is a material and a context which illustrates the application of software vividly.



📌**Trick to Start from Scratch**

Start with the one with <u>**less dependency**</u>(easier to test).



📌**What granularity should be of an object in abstract?**

Focus on an object that actually has behavior, instead of one that just a data store. However, I kind of disagree with this. In Factory pattern, it is a good practice to make a class as a data store.



📌**Does UML diagram help?**

Sometime it does and sometime it does not. The following diagram is a chart drawn at the beginning.

<img src="img/image-20220201203956074.png" alt="image-20220201203956074" style="zoom:67%;" />

However, in the final neat design. There is no `Frame` class neither `Throw` class. The design is robust enough to handle this game.



📌**When is inappropriate to use UML diagram?**

When you create them without code to validate them, and then intend to follow them.⚠❌



📌**Why code is more important than UML diagram?**

Because he best design will evolve as you take tiny little steps, writing tests first.



📌**Code**

[Bowling Game Test](./codes/Cs/Cs.sln)



# II.Agile Design





# 7.What is Agile Design?

📌**What is "The Design"?**

> ​	UML diagram $\ne$ "The Design"

> ​	Source code $=$ "The Design"

The design of a software is abstract. You CAN'T list every details of the software. Therefore, the source code is "The Design". You can only understand fully and truly by reading source codes.





📌**Design Smell - The Odors of Rotting Software**🤮

You can smell the following odors when software rotting...

- 1️⃣Rigidity - the system is hard to change since every change forces other changes as well
- 2️⃣Fragility - changes cause the system to break in places
- 3️⃣Immobility - it is hard to disentangle[^1] the system into components that can be reused in other systems
- 4️⃣Viscosity[^2] - Doing things right is harder than doing things wrong
- 5️⃣Needless Complexity - The design contains infrastructure that adds no direct benefits
- 6️⃣Needless Repetition[^3] - the design contains repeating structures that could be unified under a single abstraction
- 7️⃣Opacity - it is hard to read and understand. it does not express its intent well



📌**What Stimulates the Software to Rot?**

<img src="img/image-20220131005946416.png" alt="image-20220131005946416" style="zoom: 67%;" />

The answer is "**CHANGES**"! Bit by bit, as the changes continue, these violations accumulate, and the design begins to smell.



📌**We Can't Blame on Changes!**

Why? **<u>Because the requirements are the most volatile elements in the project</u>**.

So? We should make our designs <u>**resilient**</u> to such changes and employ practices that protect them from rotting.



📌**Story 1 - Regular Developers Encounter Changes**

> ​	Customer Requirement Ver_1:

Write a program that copies characters from the keyboard.

> ​	Code Designed Ver_1:

The program can be divided into 3 modules:

- 1️⃣ the `ReadKeyboard` module
- 2️⃣ the `Copy` program which fetches `char` from `ReadKeyboard` and routes them to the `WritePrinter` module
- 3️⃣ the `WritePrinter` module

```c++
void Copy()
{
    int c;
    while ((c=RdKbd()) != EOF)
    WrtPrt(c);
}
```



<img src="img/image-20220131120317181.png" alt="image-20220131120317181" style="zoom: 67%;" />

> ​	Customer Requirement Ver_2:

The program reads characters from the paper tape reader from time to time...

> ​	Code Designed Ver_2:

You use `bool` to encounter such changes.

```c++
bool ptFlag = false;
// remember to reset this flag
void Copy()
{
	int c;
	while ((c=(ptflag ? RdPt() : RdKbd())) != EOF)
	WrtPrt(c);
}
```



> ​	Customer Requirement Ver_3:

The Copy program needs output to the paper tape punch.

> ​	Code Designed Ver_3:

You continue the last modification philosophy and make a `bool` for the output as well.

```c++
bool ptFlag = false;
bool punchFlag = false;
// remember to reset these flags
void Copy()
{
    int c;
    while ((c=(ptflag ? RdPt() : RdKbd())) != EOF)
    	punchFlag ? WrtPunch(c) : WrtPrt(c);
}
```



> ​	Summary

During this whole process, you complained again and again...😡 You almost want to leave the job...





📌**Story 2 - Agile Developers Encounter Changes**

The difference begins at the first incoming modification when the agile developers were asked to make the program read from the paper tape reader:

> ​	Code Design Ver_2:

The team has followed the **<u>Open–Closed Principle (OCP)</u>**. This principle helps the program can be extended without modification. In the future, you can add more `Reader`.

```c++
class Reader
{
    public:
    virtual int read() = 0;
};
class KeyboardReader : public Reader
{
    public:
    virtual int read() {return RdKbd();}
};
```

From the `Copy` program perspective, you can use select different `Reader`

```c++
KeyboardReader GdefaultReader;
void Copy(Reader& reader = GdefaultReader)
{
    int c;
    while ((c=reader.read()) != EOF)
    WrtPrt(c);
}
```



> ​	Why no similar implementation on the ouput?

The reason is simple. Because the change has not been encountered! You only modify your code once needed, otherwise the code would be **Needless Complexity**.



📌**How Did the Agile Developers Know What to Do?**

1️⃣They <u>detected the problem</u> by following agile practices

2️⃣They <u>diagnosed the problem</u> by applying design principles

3️⃣They <u>solved the problem</u> by applying the appropriate design pattern.



The interplay between these 3 aspects of software development is <u>**the act of design**</u>.



📌**Conclusion**

**Agile design is a process**, not an event.















[^1]: disentangle: 解开,解耦, to separate something from the things that are twisted around it
[^2]: viscosity: 粘性
[^3]: It happens a lot in team programming. Ralph copied a block of codes which were copied by Lily which turns out to be created by Todd... and on and on... Therefore, the original idea of that code lost and hard to be maintained... Plus, if one got bugs and many places need to be fixed

