#version 330 core

out vec4 FragColor;

in vec3 newPos;

void main()
{
    FragColor = vec4(newPos, 1.0);
}
