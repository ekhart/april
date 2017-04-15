(ns game.core
  (use arcadia.core
       hard.core))

(log "hello")

(def spawner (object-named "Spawner"))
spawner
(object-named "Main Camera")
(object-named "Canvas")

(create-primitive :cube)
(destroy (object-named "Cube"))

(clone! :spawner)
