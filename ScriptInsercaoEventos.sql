USE [IngressosDB]
GO

INSERT INTO [dbo].[Evento]
           ([TituloEvento]
           ,[DescricaoEvento]
           ,[DataHoraEvento]
           ,[TotalIngressos]
           ,[TotalVendidos])
     VALUES
           ('C# para Iniciantes'
           ,'Evento destinado aos iniciantes em C# que desejam adquirir uma base sólida de conhecimentos para trabalhar com a linguagem.'
           ,'2019-02-20 08:00:00'
           ,200
           ,0),
		   ('ASP.Net para Iniciantes'
           ,'Evento destinado aos iniciantes em ASP.Net que desejam adquirir uma base sólida de conhecimentos para trabalhar com a linguagem.'
           ,'2019-02-21 08:00:00'
           ,200
           ,0),
		   ('Java para Iniciantes'
           ,'Evento destinado aos iniciantes em Java que desejam adquirir uma base sólida de conhecimentos para trabalhar com a linguagem.'
           ,'2019-02-22 08:00:00'
           ,200
           ,0)
GO


