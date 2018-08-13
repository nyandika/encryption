# Encryption

A simple Encryption and Decryption library using the AES Algorithm

:arrow_forward: [Download from Nuget](https://www.nuget.org/packages/DencryptorCore/)

:arrow_forward: Install from Package manager Console
> Install-Package DencryptorCore

## :sparkle: Main Features
The Encryption has the following custom features:

:white_check_mark: Encryption: Encrypt a plain worded string into random alphanumerics.

:white_check_mark: Decryption: Decrypt back into plain text.

## :sparkle: Usage

> Encrypting

```c#
//Initialize the encryption class
TarajiEncryption encryption = new TarajiEncryption();
//Get the interface cryptography method
var cryptographer = encryption.MakeCryptographer();
string encryptedString = cryptographer.Encrypt("stringorpasswordtoencrypt");
```

> Decrypting

```c#
//Initialize the encryption class
TarajiEncryption encryption = new TarajiEncryption();
//Get the interface cryptography method
var cryptographer = encryption.MakeCryptographer();
string plainString = cryptographer.Decrypt("IwUXysKfykPHGBOXUEiPwKzim1CUz53m26JDZGLghBs=");
```

## :sparkle: Contributing to this project
If ypu are looking to improve this library and think that other people would like it, submit a pull request. Anyone and everyone is welcome to contribute.

* You could always contact me through Email for any feature or issue. :star:

* You need [Visual Studio 2015 Community/Enterprise Edition and beyond](<https://www.visualstudio.com/>) to build the solution.


## :sparkle: Licence
The MIT License (MIT)

Copyright (c) 2016, Bespoke Fusion

Permission is hereby granted, free of charge, to any person obtaining a copy
 of this software and associated documentation files (the "Software"), to deal
 in the Software without restriction, including without limitation the rights
 to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 copies of the Software, and to permit persons to whom the Software is
 furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
 all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 THE SOFTWARE.