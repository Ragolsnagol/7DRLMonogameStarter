using Library.Entities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.MapEngine
{
    public enum CameraMode { Free, Follow }

    public class Camera
    {
        private Vector2 position;
        private float speed, zoom;

        private Rectangle viewportRectangle;

        private CameraMode mode;

        public Matrix Transformation => Matrix.CreateScale(zoom) * Matrix.CreateTranslation(new Vector3(-position, 0f));

        public Camera(Rectangle viewportRect)
        {
            speed = 4f;
            zoom = 1f;
            viewportRectangle = viewportRect;
            mode = CameraMode.Follow;
        }

        public void Update(GameTime gameTime, Player player)
        {
            //if (InputHandler.KeyReleased(Keys.Q))
            //    ZoomIn();
            //else if (InputHandler.KeyReleased(Keys.E))
            //    ZoomOut();

            if (mode == CameraMode.Follow)
            {
                LockToPlayer(player);
                return;
            }

            Vector2 motion = Vector2.Zero;

            if (InputHandler.KeyDown(Keys.Left))
                motion.X = -speed;
            else if (InputHandler.KeyDown(Keys.Right))
                motion.X = speed;

            if (InputHandler.KeyDown(Keys.Up))
                motion.Y = -speed;
            else if (InputHandler.KeyDown(Keys.Down))
                motion.Y = speed;

            if (motion != Vector2.Zero)
            {
                motion.Normalize();
                position += motion * speed;
                LockCamera();
            }
        }

        private void LockCamera()
        {
            position.X = MathHelper.Clamp(position.X, 0, Engine.BlockedMap.GetLength(0) * Engine.CharacterSize * zoom);
            position.Y = MathHelper.Clamp(position.Y, 0, Engine.BlockedMap.GetLength(1) * Engine.CharacterSize * zoom);
        }

        private void LockToPlayer(Player player)
        {
            position.X = (player.Position.X * Engine.CharacterSize) * zoom - (viewportRectangle.Width / 2);
            position.Y = (player.Position.Y * Engine.CharacterSize) * zoom - (viewportRectangle.Height / 2);

            LockCamera();
        }

        public void ZoomIn()
        {
            zoom += .25f;

            if (zoom > 2.5f)
                zoom = 2.5f;

            Vector2 newPosition = position * zoom;
            SnapToPosition(newPosition);

        }

        public void ZoomOut()
        {
            zoom -= .25f;

            if (zoom < .5f)
                zoom = .5f;

            Vector2 newPosition = position * zoom;
            SnapToPosition(newPosition);

        }

        private void SnapToPosition(Vector2 newPosition)
        {
            position.X = newPosition.X - viewportRectangle.Width / 2;
            position.Y = newPosition.Y - viewportRectangle.Height / 2;
            LockCamera();
        }

        public void ToggleCameraMode()
        {
            if (mode == CameraMode.Follow)
                mode = CameraMode.Free;
            else
                mode = CameraMode.Follow;
        }
    }
}
