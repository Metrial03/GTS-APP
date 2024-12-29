USE GTS

INSERT INTO PERSON VALUES
(1, 'Alice', 'Johnson'),
(2, 'Bob', 'Smith'),
(3, 'Carol', 'Davis'),
(4, 'David', 'Garcia'),
(5, 'Eve', 'Martinez')

INSERT INTO UNIVERSITY VALUES
('Massachusetts Institute of Technology'),
('Stanford University'),
('University of Cambridge'),
('Harvard University'),
('California Institute of Technology')

INSERT INTO INSTITUTE VALUES
('Computer Science Department', 'Massachusetts Institute of Technology'),
('Biology Department', 'Stanford University'),
('Physics Department', 'University of Cambridge'),
('Law School', 'Harvard University'),
('Engineering Division', 'California Institute of Technology')

INSERT INTO SUBJECT_TOPIC VALUES
('Artificial Intelligence'),
('Quantum Computing'),
('Genetics'),
('Robotics'),
('Renewable Energy'),
('Constitutional Law')

INSERT INTO LANG VALUES
('Turkish'),
('English'),
('Spanish'),
('French'),
('German'),
('Chinese')

INSERT INTO THESIS VALUES
(1000001, 'Deep Learning Approaches in AI', 'A study on neural networks and their applications.', 1, 2023, 'Doctorate', 'Massachusetts Institute of Technology', 'Computer Science Department', 150, 'English', '2023-06-15'),
(1000002, 'Genetic Markers in Cancer Research', 'Identification of genetic markers for early cancer detection.', 2, 2022, 'Master', 'Stanford University', 'Biology Department', 120, 'French', '2022-05-20'),
(1000003, 'Quantum Entanglement and Applications', 'An exploration of quantum physics and its potential uses.', 3, 2021, 'Doctorate', 'University of Cambridge', 'Physics Department', 200, 'Chinese', '2021-08-10'),
(1000004, 'Renewable Energy Policies', 'Policy recommendations for sustainable energy usage.', 4, 2020, 'Master', 'Harvard University', 'Law School', 80, 'English', '2020-11-25'),
(1000005, 'Advanced Robotics Systems', 'Study of robotic systems for industrial automation.', 5, 2023, 'Doctorate', 'California Institute of Technology', 'Engineering Division', 180, 'English', '2023-07-01')

INSERT INTO SUPERVISOR VALUES
(1000001, 5, 2),
(1000002, 3, NULL),
(1000003, 1, 4),
(1000004, 2, 1),
(1000005, 4, 3)

INSERT INTO THESIS_TOPIC VALUES
(1000001, 'Artificial Intelligence'),
(1000002, 'Genetics'),
(1000003, 'Quantum Computing'),
(1000004, 'Renewable Energy'),
(1000005, 'Robotics')

INSERT INTO THESIS_KEYWORD VALUES
(1000001, 'Deep Learning'),
(1000001, 'Neural Networks'),
(1000002, 'Genetic Markers'),
(1000003, 'Quantum Entanglement'),
(1000004, 'Energy Policy'),
(1000005, 'Industrial Automation')
