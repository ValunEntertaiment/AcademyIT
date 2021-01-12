SELECT scores.id,
	   cources.name_cource as cource,
       students.FIO AS student,
       score
FROM `scores`
inner JOIN students ON (students.id = scores.student)
inner JOIN cources on (cources.id = scores.cource)
WHERE cources.name_cource = "Программирование"
	  and score >= 4