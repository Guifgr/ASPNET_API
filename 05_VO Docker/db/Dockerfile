FROM mysql:5.7.22
EXPOSE 3306
COPY ./VODocker/db/migrations /home/database
COPY ./VODocker/db/dataset /home/database
COPY ./VODocker/ci/init_database.sh /docker-entrypoint-initdb.d/init_database.sh