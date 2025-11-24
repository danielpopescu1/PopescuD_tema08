using OpenTK.Graphics.OpenGL;

namespace OpenTK_winforms_z02
{
    public class LightSource
    {
        public bool Enabled { get; set; }
        public int LightId { get; set; }

        public float[] Ambient = new float[4];
        public float[] Diffuse = new float[4];
        public float[] Specular = new float[4];
        public float[] Position = new float[4];

        public LightSource(int id)
        {
            LightId = id;
            Enabled = false;
        }

        public void Apply()
        {
            if (!Enabled)
            {
                GL.Disable((EnableCap)LightId);
                return;
            }

            GL.Light((LightName)LightId, LightParameter.Ambient, Ambient);
            GL.Light((LightName)LightId, LightParameter.Diffuse, Diffuse);
            GL.Light((LightName)LightId, LightParameter.Specular, Specular);
            GL.Light((LightName)LightId, LightParameter.Position, Position);
            GL.Enable((EnableCap)LightId);
        }
    }
}
