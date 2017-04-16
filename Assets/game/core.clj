(ns game.core
  (use arcadia.core
       hard.core)
  (import [UnityEngine GameObject]))

(log "hello")
(log "test")

(def spawner (object-named "Spawner"))
spawner
(object-named "Main Camera")
(object-named "Canvas")

(create-primitive :cube)
(destroy (object-named "Cube"))

(clone! :spawner)
(clone! "Spawner")

(objects-named "Spawner")

(GameObject/Find "Spawner")
(GameObject/Find "Canvas")
;; GameObject/Find

(def spawner (object-tagged "Spawner"))
spawner
; (.activeSelf spawner)
; (.transform spawner)
; (.tag spawner)
; (.name spawner)
; spawner
; (.gameObject spawner)
; (.SetActive spawner true)
