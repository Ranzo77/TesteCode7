# TesteCode7

Instruções de execução para rodar os testes.

Para rodar os testes é necessário abrir o gerenciador de testes da solução.

Testes : TC001_CreateGoogleAccount e TC0002_ContactCode7
Estes dois TC's simulam operações de UI, alguns dados são necessários para realizar o teste como email, nome mensagem e etc.
Estes dados foram parametrizados via JSON, portando, ao baixar a solução é necessário alterar os dados contidos no JSON e o caminho deste na solução.
Os dois arquivos se encontram dentro da solução, dentro do projeto "Testes", Code7.JSON e GoogleAccount.JSON, para alterar os dados basta abrir e realizar a alteração.

É necessário dentro destes dois TC'S alterar o path do caminho, o método responsável é (DeserializeCode7Json)

TC001_CreateGoogleAccount - linha 27 - TC0002_ContactCode7 - linha 62

        public GoogleAccountJson DeserializeCode7Json()
        {
            var reader = new StreamReader(@"C:\Users\Felipe\source\repos\TesteCode7\Testes\GoogleAccount.json");
            var jsonFile = reader.ReadToEnd();
            var serializer = new JavaScriptSerializer();

            return serializer.Deserialize<GoogleAccountJson>(jsonFile);
        }

OBS: Para pegar o caminho completo de maneira mais simples, basta clicar com o botão direito no arquivo dentro da solução e clicar em copiar caminho completo.
Após esta alteração, basta executar os testes.

O TC: TC001_CreateGoogleAccount contém uma particularidade, é necessário passar um numero de telefone para que seja enviado um codigo de validação.
Então é necessário colocar o código hardcoded em tempo de execução, colocar um breakpoint na linha e assim que a mensagem for enviada alterar o valor.

linha 39:
            
         /*Informe o código de validação!*/
         var validateCode = "543290";

Em seguida basta dar sequência no TC.

Os demais testes são testes da API, foi usada a API recomendada no teste passado.
