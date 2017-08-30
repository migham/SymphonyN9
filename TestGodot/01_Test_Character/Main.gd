extends Node2D

var img
const SPEED = 200
var escala
var rotacion

func _ready():
	# Called every time the node is added to the scene.
	# Initialization here
	img = get_node("Sprite")
	escala = Vector2(1, 1)
	rotacion = 0.0
	set_process(true)
	pass
	
func _process(delta):
	var motion = Vector2()
	
	if Input.is_action_pressed("ui_up"):
		motion += Vector2(0, -1)
	if Input.is_action_pressed("ui_right"):
		motion += Vector2(1, 0)
	if Input.is_action_pressed("ui_left"):
		motion += Vector2(-1, 0)
	if Input.is_action_pressed("ui_down"):
		motion += Vector2(0, 1)
	if Input.is_action_pressed("ui_rotar_der"):
		rotacion -= 2
	if Input.is_action_pressed("ui_rotar_izq"):
		rotacion += 2
		
#	if Input.is_action_pressed("ui_saltar"):
#		escala.x += 0.02
#		escala.y += 0.02
#	if Input.
#		if escala.x > 1:
#			escala.x -= 0.02
#			escala.y -= 0.0
	
#	img.set_scale(escala)
	img.set_rot(deg2rad(rotacion))
	var pos = img.get_pos()
	pos += motion * delta * SPEED
	
	img.set_pos(pos)
	pass
