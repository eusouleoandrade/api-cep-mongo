# ApiCepMongo
Api foi contruída para estudo do .NET Framework Web Api e MongoDB.

## Resumo
A Web Api consome um ou mais serviço de busca de endereço com CEP. O endpoint recebe um CEP e consome outras APIs (ViaMaisCep ou WebManiaCep) que retorna um json. Este json é tratado, convertido em objeto, salvo no MongoDB e retornado para endpoint.

## Tecnologias
Foi usado o .NET Framework 4.7.2 como Web Api. O reporitório é persistido no MongoDB.

## Arquitetura
A arquitetura foi desenvolvida respeitando os princípios do SOLID. 

## Repositório
O projeto está implementado com o MongoDB, mas a estrutura possibilita a inserção de diversos repositórios.

## Serviços de CEP implementados
A solução consulta os serviços listados abaixo. A estrutura possibilita a inserção de outros serviços para consulta de Cep.

[ViaCep](https://viacep.com.br/)

[WebManiaCep](https://webmaniabr.com/docs/rest-api-cep-ibge/)

