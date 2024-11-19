-- create enum for type
CREATE TYPE user_role AS ENUM ('workspace_owner', 'developer', 'project_manager');
CREATE TYPE status AS ENUM ('not_started', 'in_progress', 'completed', 'cancelled');
CREATE TYPE ticket_type AS ENUM ('bug', 'feature', 'technical_debt');
CREATE TYPE priority AS ENUM ('emergency', 'high', 'medium', 'low');

CREATE TABLE IF NOT EXISTS STATUS_TABLE (
	id UUID PRIMARY KEY,
	status STATUS
);

-- create the tables for entities and put in references
-- user is a reserved word in sql so we have to use app_user instead
CREATE TABLE IF NOT EXISTS APP_USER (
	id UUID PRIMARY KEY NOT NULL,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NULL NULL,
	email VARCHAR(100) Unique NOT NULL,
	password_hash VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS WORKSPACE (
	id UUID PRIMARY KEY NOT NULL,
	name VARCHAR(100) NOT NULL,
	owner_id UUID REFERENCES APP_USER(id) ON DELETE SET NULL
);

CREATE TABLE IF NOT EXISTS STATUS_TABLE (
	id UUID PRIMARY KEY,
	status STATUS
);

CREATE TABLE IF NOT EXISTS PROJECT (
	id UUID PRIMARY KEY NOT NULL,
	name VARCHAR(100) NOT NULL,
	description VARCHAR(400),
	start_date DATE,
	end_date DATE,
	status_id UUID REFERENCES STATUS_TABLE(id),
	workspace_id UUID REFERENCES WORKSPACE(id) ON DELETE CASCADE
	CHECK (start_date >= now())
	CHECK (end_date > start_date)
);

CREATE TABLE IF NOT EXISTS TICKET (
	id UUID PRIMARY KEY NOT NULL,
	title VARCHAR(100),
	description VARCHAR(500),
	priority priority,
	deadline DATE,
	status_ID UUID REFERENCES STATUS_TABLE(id),
	project_ID UUID REFERENCES PROJECT(id) ON DELETE CASCADE,
	ticket_type ticket_type
);

-- many-many relationship tables
CREATE TABLE IF NOT EXISTS USER_WORKSPACE (
	user_id UUID REFERENCES APP_USER(id),
	workspace_id UUID REFERENCES WORKSPACE(id),
	role user_role,
	PRIMARY KEY(user_id, workspace_id)
);

CREATE TABLE IF NOT EXISTS USER_PROJECT (
	user_id UUID REFERENCES APP_USER(id),
	project_id UUID REFERENCES PROJECT(id),
	PRIMARY KEY(user_id, project_id)
);

CREATE TABLE IF NOT EXISTS USER_TICKET (
	user_id UUID REFERENCES APP_USER(id),
	ticket_id UUID REFERENCES TICKET(id),
	PRIMARY KEY(user_id, ticket_id)
);

