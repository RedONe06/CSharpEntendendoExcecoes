![image](https://user-images.githubusercontent.com/98191980/191503440-96eb335b-0cf7-4495-9dc7-bcb8c9c95cb4.png)

<img src="https://img.shields.io/static/v1?label=by&message=Alura&color=blue&style=for-the-badge"> <img src="https://img.shields.io/static/v1?label=Tech&message=.NET 6.0&color=00cccc&style=for-the-badge&logo=.NET"> <img src="https://img.shields.io/static/v1?label=Tech&message=C%23&color=00cccc&style=for-the-badge&logo=csharp">

`Notebook:` [Google Docs](https://docs.google.com/document/d/18S0hiWvui3Cx18kKtef1YT7-LQxYUxotC6bJtQUel-4/edit?usp=sharing)

### Primeiros passos com excessões

- Como funciona a pilha de chamadas (CallStack) no .NET;
- Não é correto propagar erros com retorno de métodos não é correto;
- Podemos usar as exceções do .NET e para tratá-las, basta usar os blocos try/catch;
- As exceções são representadas por objetos e duas propriedades importantes são a Message e StackTrace.

### Tratamento de excessões

- O bloco try pode acompanhar vários blocos catch;
- A CLR visita os blocos catch em ordem, de cima para baixo. Por essa razão, os tipos de exceção mais específicos devem estar no começo;
- A instrução throw;, dentro de um bloco catch, relança uma exceção.
