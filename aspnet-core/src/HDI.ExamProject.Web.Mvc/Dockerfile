FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

RUN dotnet tool install -g Microsoft.Web.LibraryManager.Cli
RUN ln -s ~/.dotnet/tools/libman /usr/local/bin/libman

WORKDIR /src
COPY ["src/HDI.ExamProject.Web.Mvc/HDI.ExamProject.Web.Mvc.csproj", "src/HDI.ExamProject.Web.Mvc/"]
COPY ["src/HDI.ExamProject.Web.Core/HDI.ExamProject.Web.Core.csproj", "src/HDI.ExamProject.Web.Core/"]
COPY ["src/HDI.ExamProject.Application/HDI.ExamProject.Application.csproj", "src/HDI.ExamProject.Application/"]
COPY ["src/HDI.ExamProject.Core/HDI.ExamProject.Core.csproj", "src/HDI.ExamProject.Core/"]
COPY ["src/HDI.ExamProject.EntityFrameworkCore/HDI.ExamProject.EntityFrameworkCore.csproj", "src/HDI.ExamProject.EntityFrameworkCore/"]
WORKDIR "/src/src/HDI.ExamProject.Web.Mvc"
RUN dotnet restore 

WORKDIR /src
COPY ["src/HDI.ExamProject.Web.Mvc", "src/HDI.ExamProject.Web.Mvc"]
COPY ["src/HDI.ExamProject.Web.Core", "src/HDI.ExamProject.Web.Core"]
COPY ["src/HDI.ExamProject.Application", "src/HDI.ExamProject.Application"]
COPY ["src/HDI.ExamProject.Core", "src/HDI.ExamProject.Core"]
COPY ["src/HDI.ExamProject.EntityFrameworkCore", "src/HDI.ExamProject.EntityFrameworkCore"]
WORKDIR "/src/src/HDI.ExamProject.Web.Mvc"
RUN libman restore
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "HDI.ExamProject.Web.Mvc.dll"]
