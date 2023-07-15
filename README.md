Proje Yapısı:

    Proje Katmanları: Application, Core, EntityFrameworkCore, Web
    
    Veritabanı: SQL Server
    
      * Veritabanı Şeması:
      
      * Tablolar: Products, Customers, Dealers, Services
      
      * İlişkiler: Products (1-N) Customers, Products (N-N) Dealers, Products (N-N) Services
      
    Proje Dosyaları:
    
        * HDI.ExamProject.Application 
        
          - ProductAppService.cs - IProductAppService.cs - DTO
          
          - CustomerAppService.cs - ICustomerAppService.cs - DTO
          
          - DealerAppService.cs - IDealerAppService.cs - DTO
          
          - ServiceAppService.cs - IServiceAppService - DTO
          
        * HDI.ExamProject.Core 
        
          - Entities / Product, Customer, Dealer, Service
          
          - Repositories / IProductRepository, ICustomerRepository, IDealerRepository, IServiceRepository
          
        * HDI.ExamProject.EntityFrameworkCore 
        
          - DbContext / HDI.ExamProjectDbContext
          
          - Migrations 
          
        * HDI.ExamProject.Web 
        
          - Controllers / ProductController, CustomerController, DealerController, Service"Controller
          
          - Views / Product.cshtml, Customer.cshtml, Dealer.cshtml, Service.cshtml)
