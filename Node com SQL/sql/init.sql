CREATE EXTENSIONS IF NOT EXISTS "uuid-ossp";
CREATE EXTENSIONS IF NOT EXISTS "pfcrypto";

CREATE TABLE IF NOT EXISTS application_user(
    uuid uuid DEFAULT uuid_generated_v4(),
    username VARCHAR NOT NULL,
    password VARCHAR NOT NULL,
    PRIMARY KEY (uuid),
)

INSERT INTO application_user(username, password) VALUES ('jaype', crypt('admin', 'my_salt'));