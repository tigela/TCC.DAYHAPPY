# TCC.DAYHAPPY
TCC

---ARROMBADINHO LER A MERDA ANTES DE COMMITAR PRA NAO DA MERDA

TEMOS 2 branchs o MASTER que é com (string de conexao) e o improve_method_watch que é o mais recente 
do Entity

--para checar o branch git branch
ira aparecer
*master
*improve_method_watch

--para MUDAR o branch
git checkout improve_method_watch 
git checkout master

sempre ira aparecer em qual vc esta entre parenteses (master)/(improve_method_watch) por padrao é o master
--->>>>>>(ATENÇÃO ARROMBADINHO)antes de qualquer push ou commit fazer o pull para baixaro prejeto novo

git init --> para iniciar o git

git pull origin master 

--ou no entity

git pull improve_method_watch

--> para dar push

git status

git add .

git status

git commit -m "comentario"

git push -u origin master -> senha padrao 123456
git push origin improve_method_watch



verificar no site se foi


------------ outros comandos ----


git push -f origin master -> forcar a commit

ssh-keygen -> cria uma senha ao seu repositorio (NÃO USAR NO NOSSO PROJETO) (usar so quando vc criar um novo repositorio)

git config --global push.default current -> restaura as config do push

git checkout -b improve_method_watch

git branch improve_method_watch

git clone git@github.com:tigelah/Tcc.DayHappy.git clonar o repositorio

git remote add origin git@github.com:tigelah/Tcc.DayHappy.git --> adicionar um acesso ao repositorio

git config --global user.name "seu nome aqui"

git config --global user.email "seu email aqui"

Criar uma branch local:
git checkout -b nome-branch-local

Listar Branchs remotas:
git branch -r

Listar Todas as Branchs remotas e locais:
git branch -a
