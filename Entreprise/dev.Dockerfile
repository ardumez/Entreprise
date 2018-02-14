FROM microsoft/aspnetcore-build:1.1.1

EXPOSE 80/tcp

VOLUME /app

WORKDIR /app

ENTRYPOINT echo "Listing du repertoire en cours..."