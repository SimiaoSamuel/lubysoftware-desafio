DELETE tabela_pessoa
FROM tabela_pessoa
        LEFT JOIN
    tabela_evento ON tabela_pessoa.id = tabela_evento.pessoa_id 
WHERE
    tabela_evento.id IS NULL;