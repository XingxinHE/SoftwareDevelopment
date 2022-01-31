# I.Agile Development

# 1.Agile Practices

# 2.Overview of Extreme Programming

# 3.Planning

# 4.Testing





# 5.Refactoring

:pushpin:**What is the responsibility of software module?**

There are **3** functions.

- :one: The function <u>**perform**</u> while executing.
- :two: The function of a module to **<u>afford change</u>**.
- :three: The function to <u>**communicate**</u> to its reader.



:pushpin:**What Refactoring does?**

It helps the preceding 3 functions.



:pushpin:**Good Naming**

After reading this chapter, I found out a good name for variable is super important!!



:pushpin:**Split the Procedure**

An easy to understand code should be split into a clear function.



:pushpin:**Effect of Refactoring**

The structure of the program is isolated from parts to parts.

The program is much more easier to be changed.



:pushpin:**When should you to refactor?**

The answer is everyday! Clean your code everyday.



:pushpin:**Does refactoring important?**

Yes, it is super important. Because refactoring produces **clean code** which is the utmost importance. Before investing in principles and patterns, invest in clean code.



:pushpin:**Example of Refactoring**

Please refer to the following commits.

[Version 1](https://github.com/XingxinHE/SoftwareDevelopment/commit/aa2e6e7aacd2178c572ccfc06c43705c024c244c)

[Version 2](https://github.com/XingxinHE/SoftwareDevelopment/commit/3ebeb30e64804e7b11e9983c435a0f0bc6c428c1)

[Version 3](https://github.com/XingxinHE/SoftwareDevelopment/commit/663713ce4c20e49d4ae31bde25e62f837b977c4f)

[Version 4](https://github.com/XingxinHE/SoftwareDevelopment/commit/dfc6d57b4a69607e6f199d8e3f5d149f3d1b0b68)

[Version final](https://github.com/XingxinHE/SoftwareDevelopment/commit/07e03f3e46bc928fe4a8984cc00b8e4e9de45ec5)



# 6.Programming Episode



# II.Agile Design





# 7.What is Agile Design?

:pushpin:**What is "The Design"?**

> ​	UML diagram $\ne$ "The Design"

> ​	Source code $=$ "The Design"

The design of a software is abstract. You CAN'T list every details of the software. Therefore, the source code is "The Design". You can only understand fully and truly by reading source codes.





:pushpin:**Design Smell - The Odors of Rotting Software**🤮

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









[^1]: disentangle: 解开,解耦, to separate something from the things that are twisted around it
[^2]: viscosity: 粘性
[^3]: It happens a lot in team programming. Ralph copied a block of codes which were copied by Lily which turns out to be created by Todd... and on and on... Therefore, the original idea of that code lost and hard to be maintained... Plus, if one got bugs and many places need to be fixed

