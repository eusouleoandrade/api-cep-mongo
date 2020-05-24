# ApiCepMongo
Api foi contruída para estudo do .NET Framework Web Api e MongoDB.

## Resumo
A Web Api consome um ou mais serviço de busca de endereço com CEP. O endpoint recebe um CEP e consome outras APIs (ViaMaisCep ou WebManiaCep) que retorna um json. Este json é tratado, convertido em objeto, salvo no MongoDB e retornado para endpoint.

## Tecnologias
Foi usado o .NET Framework 4.7.2 como Web Api. O reporitório é persistido no MongoDB.

## Arquitetura
A arquitetura foi desenvolvida respeitando os princípios do SOLID. O service foi dinsponibilizado para consumir qualquer serviço de CEP, basta usar as interfaces, assinar os métodos e usar a injeção de dependência.

## Repositório
A implementação possibilita a inserção de outros repositórios. Está implementado o MongoDB, e os arquivos da Collection encontra-se no path Data\Mongo\db.

## Serviços de CEP implementados
[ViaCep](https://viacep.com.br/)

[WebManiaCep](https://webmaniabr.com/docs/rest-api-cep-ibge/)

