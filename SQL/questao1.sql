SELECT `tabela_evento`.*, `tabela_pessoa`.`nome` FROM `tabela_evento` 
	INNER JOIN `tabela_pessoa` ON `tabela_evento`.`pessoa_id` = `tabela_pessoa`.`id`
    