// will be applied to an INVISIBLE object that will make other objects transparent

Shader "Custom/XrayShader"
{
    SubShader
    {
        Tags { "Queue"="Transparent+1" }		// render after all transparent objects (queue = 3001)
        Pass { Blend Zero One}					// makes the object transparent
    }
}
