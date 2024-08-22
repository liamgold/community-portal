import { Editor, defaultValueCtx, rootCtx } from '@milkdown/core';
import { listener, listenerCtx } from '@milkdown/plugin-listener';
import { commonmark } from '@milkdown/preset-commonmark';
import { Milkdown, useEditor } from '@milkdown/react';
import { history } from '@milkdown/plugin-history';
import * as React from 'react';

export type MilkdownEditorProps = {
  defaultValue?: string;
  UpdateValue: (markdown: string) => void;
};

export const MilkdownEditor: React.FC<MilkdownEditorProps> = (props) => {
  useEditor((root) =>
    Editor.make()
      .config((ctx) => {
        ctx.set(rootCtx, root);
        ctx.set(defaultValueCtx, props.defaultValue || '');

        const listener = ctx.get(listenerCtx);
        listener.markdownUpdated((ctx, markdown, prevMarkdown) => {
          if (markdown !== prevMarkdown) {
            props.UpdateValue(markdown);
          }
        });
      })
      .use(commonmark)
      .use(listener)
      .use(history),
  );

  return <Milkdown />;
};
