 #!/bin/bash
 
 echo "se han pasado $# parámetros"
 echo "los parametros son $*"
 echo "los parametros son $@"
 echo "recorriendo los parametros"
 
 for parametro in $*
 do
 	echo $parametro
 done
 
  for parametro in $@
 do
 	echo $parametro
 done
